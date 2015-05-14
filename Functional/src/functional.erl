%%%-------------------------------------------------------------------
%%% @author Vladimir
%%% @copyright (C) 2015, <COMPANY>
%%% @doc
%%%
%%% @end
%%% Created : 23. Апр. 2015 11:47
%%%-------------------------------------------------------------------
-module(sda).
-author("Vladimir").

%% API
-export([text/2,writeLetter/1]).

test(Text,Address)->
  .

writeLetter(Text) when list(Text) = true ->
  Text;
writeLetter(Text)->
  io:format(Text," is not valid").

send(Text,Address)->
  {Text,Address}