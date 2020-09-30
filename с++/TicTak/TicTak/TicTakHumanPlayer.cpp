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
	cout << "�����" << name << ",��� ��� " << endl;
	cout << "������� ������:";
	cin >> row;
	cout << "������� �������:";
	cin >> col;
	if (this->board->CheckLegal(col, row))
	{
		this->board->SetCell(col, row, this->cellType);
		return true;
	}
	return false;
}