%%%-------------------------------------------------------------------
%%% @author Vladimir
%%% @copyright (C) 2015, <COMPANY>
%%% @doc
%%%
%%% @end
%%% Created : 27. Март 2015 22:53
%%%-------------------------------------------------------------------
-module(mess).
-author("Vladimir").

%% API
-export([start/0,pacan/1,loh/2]).


loh(0,Name)->
  pacan ! ya_zassal,
  io:format("[~w] Lan harosh palehchi ya zassal ok~n",[Name]);
loh(HP,Name)->
  pacan ! {Name,self()},
  receive
    {PacanName,ohuel} ->
      io:format("[~w] Da ne pizdi, ~w, ty nihuya ne pacan~n",[Name,PacanName]),
      loh(HP-1,Name);
    {PacanName,pizda_tebe} ->
      io:format("[~w] BLYAT, ~w, NE YBIVAAAAii.....~n",[Name,PacanName])
  end.

pacan(Name)->
  receive
    ya_zassal ->
      io:format("[~w] Loh ebaniy, mat tvou delal~n",[Name]),
      pacan(Name);
    {LohName,Loh_PID} ->
      io:format("[~w] ~w, idi suda, huylo~n",[Name,LohName]),
      Loh_PID ! {Name,ohuel},
      pacan(Name)
  end.

start()->
  register(pacan,spawn(mess,pacan,['Andruyha'])),
  spawn(mess,loh,[4,'Vitalya']),
  spawn(mess,loh,[7,'Vovan']),
  spawn(mess,loh,[15,'Ahmed']),
  spawn(mess,loh,[6,'Ali']),
  spawn(mess,loh,[1,'Ivan Ivanych']),
  spawn(mess,loh,[10,'baba Nura']).