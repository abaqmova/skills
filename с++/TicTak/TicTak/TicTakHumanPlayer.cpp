#include "pch.h"
#include "TicTakHumanPlayer.h"

TicTakHumanPlayer::TicTakHumanPlayer()
{
}

TicTakHumanPlayer::~TicTakHumanPlayer()
{
}
bool TicTakHumanPlayer::MakeMove()
{
	unsigned int row, col;
	cout << "игрок" << name << ",ваш ход " << endl;
	cout << "введите сторку:";
	cin >> row;
	cout << "введите столбец:";
	cin >> col;
	if (this->board->CheckLegal(col, row))
	{
		this->board->SetCell(col, row, this->cellType);
		return true;
	}
	return false;
}