#include "pch.h"
#include<iostream>
#include"TicTakManager.h"
#include"TicTakHumanPlayer.h"
#include"TicTakCompuerPlayer.h"



TicTakManager::TicTakManager()
{
}

TicTakManager::~TicTakManager()
{
	delete this->board;
	delete this->player1;
	delete this->player2;
}
bool TicTakManager::Init()
{
	unsigned int boardsize;
	string playerName;
	int playertype;
	cout << "������� ����� ������ ����(3-6):";
	cin >> boardsize;
	if ((boardsize < 3) || (boardsize > 6))
	{
		cout << "�������� ����� ������ ����" << endl;
		return false;
	}
	this->board = new TicTakBoard(boardsize);
	cout << "������� ��� ������ #1 (1-������, ����� ������ �����- ���������):";
		cin >> playertype;
		if (playertype == 1)
			this->player1 = new TicTakHumanPlayer();
		else
			this->player1 = new TicTakCompuerPlayer();
	cout << "������� ��� ������ #2 (1 - �������, ����� ������ ����� - ���������):";
	cin >> playertype;
	if (playertype == 1)
		this->player2 = new TicTakHumanPlayer();
	else
		this->player2 = new TicTakCompuerPlayer();
	cin.ignore();
	cout << "������� ��� ������, ��������� �:";
	getline(cin, playerName);
	player1->SetupPlayer(playerName, CellType_X);
	cout << "������� ��� ������, ��������� O:";
	getline(cin, playerName);
	player2->SetupPlayer(playerName, CellType_O);
	player1->SetBoard(this->board);
	player2->SetBoard(this->board);
	currentPlayer = player1;
	return true;
}
void TicTakManager::ShowBoard()
{
	this->board->Show();
}

void TicTakManager::MakeMove()
{
	ShowBoard();
	while (!currentPlayer->MakeMove())
	{
		cout << "������������ ���, ����������  ��� ���" << endl;
		ShowBoard();
	}
	if (this->board->CheckEndCondition()) 
	{
		if (this->board->IsVictory())
			cout << "�����" << currentPlayer->GetName() << "�������!" << endl;
		else
			cout << "�����!" << endl;
		this->bGameFinished = true;
		ShowBoard();
		return;
	}
	currentPlayer = (currentPlayer == player1) ? player2 : player1;
}

bool TicTakManager::IsGameFinished()
{
	return bGameFinished;
}
