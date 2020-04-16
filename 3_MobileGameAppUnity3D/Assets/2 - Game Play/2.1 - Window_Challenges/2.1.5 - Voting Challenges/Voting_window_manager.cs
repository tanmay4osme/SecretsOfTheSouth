﻿/**
Copyright (c)  2019, Francisco Xavier Dos Santos Fonseca (Ordem dos Engenheiros n.º 84598), and Technical University of Delft. 
All rights reserved. 

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met: 

1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer. 

2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution. 

3. All advertising materials mentioning features or use of this software must display the following acknowledgement: 
This product includes software developed by the Technical University of Delft. 

4. Neither the name of  the copyright holder nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY  COPYRIGHT HOLDER "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL  COPYRIGHT HOLDER BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class Voting_window_manager : MonoBehaviour {

	public DisplayManager_FeedBack_VotingWindow_Scene_2 _referenceDisplayManager;

	//public GameObject popupQuestionPanel;
	//public GameObject popupAnswerPanel;
	//public Button showQuestionButton, showAnswerButton, closeButton;
	public Text taskHolder, descriptionHolder, titleHolder;
	public Image imageHolder;
	public ScrollRect descriptionScrollViewPanel; // this is to put the text of the description always up
	public List<GameObject> panels;
	// 0 - pop up question panel
	// 1 - pop up answer panel


	//[HideInInspector]
	//public VotingChallengeInfo votingChallengeBeingSolved;

	// Use this for initialization
	/*public void ActivateWindow()
	{
		GameManager.instance.isAnyWindowOpen = true;
		GameManager.instance.votingChallengeWindow.SetActive(true);

		Debug.Log ("[Voting_Window] Challenge ID:  " + GameManager.currentVotingChallengeBeingSolved._id);

		//GameManager.instance.votingChallengeWindowManager.panels [0].SetActive (false);
		//GameManager.instance.votingChallengeWindowManager.panels [1].SetActive (false);
	}

	public void CloseWindow()
	{
		//GameManager.instance.hunterChallengeWindowManager.panels [0].SetActive (false);
		//GameManager.instance.hunterChallengeWindowManager.panels [1].SetActive (false);

		GameManager.currentVotingChallengeBeingSolved = null;

		GameManager.instance.votingChallengeWindow.SetActive(false);
		GameManager.instance.isAnyWindowOpen = false;
	}*/
}
