#pragma once
#include "TicTakPlayer.h"
class TicTakCompuerPlayer :
	public TicTakPlayer
{
public:
	TicTakCompuerPlayer();
	virtual ~TicTakCompuerPlayer();
	virtual bool MakeMove();
};

