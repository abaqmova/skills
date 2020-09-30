#pragma once
#include "TicTakPlayer.h"
class TicTakRandomPlayer :
	public TicTakPlayer
{
public:
	TicTakRandomPlayer();
	virtual ~TicTakRandomPlayer();
	virtual bool MakeMove();
};

