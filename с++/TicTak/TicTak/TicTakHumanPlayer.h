#pragma once
#include"TicTakBoard.h"
#include"TicTakPlayer.h"
class TicTakHumanPlayer: public TicTakPlayer
{
public:
	TicTakHumanPlayer();
	virtual ~TicTakHumanPlayer();
	 virtual bool MakeMove();
	
};

