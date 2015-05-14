%%%-------------------------------------------------------------------
%%% @author Vladimir
%%% @copyright (C) 2015, <COMPANY>
%%% @doc
%%%
%%% @end
%%% Created : 28. Март 2015 22:41
%%%-------------------------------------------------------------------
-module(power).
-author("Vladimir").

%% API
-export([start/3]).


power(A,0)->
  1;
power(A,1)->
  A;
power(A,B)->
  power(A*A,B-1).

cycle(F,Args,1)->
  apply(F,Args);
cycle(F,Args,N)->
  apply(F,Args),
  cycle(F,Args,N-1).

start(A,B,0)->
  A;
start(A,B,N)->
  apply(power,[A,B]).
  %cycle(power,[A,B],N).