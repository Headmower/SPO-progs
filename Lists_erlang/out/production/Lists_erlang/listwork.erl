-module(listwork).
-export([start/3, process/3]).


generatelist(0,LIST)->
  LIST
  %io:format(".")
  ;
generatelist(N,LIST)->
  generatelist(N-1,[N|LIST]).

generatelist(N)->
  generatelist(N-1,[N]).


writemessage(N,M)->
  io:format("Generated ~w lists of length ~w elements~n~n",[M,N]).


gen(N,0)->
  generatelist(N);
gen(N,M)->
  generatelist(N),
  gen(N,M-1).

process(ProcNumber,Len,Count)->
  {HS,MS,SS} = time(),
  gen(Len,Count),
  {HE,ME,SE} = time(),
  io:format("[~w]Generated ~w lists of length ~w elements~nWorking time: ~w~n~n",[ProcNumber,Count,Len,{HE-HS,ME-MS,SE-SS}]),
  mainproc ! finished.

divide_by_processes(F,Len,Count,0,1)->
  spawn(listwork,F,[1,Len,Count]);
divide_by_processes(F,Len,Count,0,Threads)->
  spawn(listwork,F,[Threads,Len,Count]),
  divide_by_processes(F,Len,Count,0,Threads-1);
divide_by_processes(F,Len,Count,Extra,Threads)->
  spawn(listwork,F,[Threads,Len,Count+1]),
  divide_by_processes(F,Len,Count,Extra-1,Threads-1).

waiter(0)->
  endd;
waiter(T)->
  receive
    finished ->
      waiter(T-1)
  end.

start(N,M,0)->
  halt();
start(Len,Count,1)->
  process(main,Len,Count);
start(Len,Count,Threads)->
  register(mainproc,self()),
  divide_by_processes(process,Len,Count div Threads,Count rem Threads,Threads),
  waiter(Threads).