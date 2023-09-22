using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ATMSystemManager : MonoBehaviour
{
    public GameObject select;
    public GameObject deposit;
    public GameObject withdrawal;

    public GameObject notice;

    public TextMeshProUGUI cash;
    public TextMeshProUGUI balance;

    public TextMeshProUGUI depositInput;
    public TextMeshProUGUI withdrawalInput;

    public void SelectDepositButton()
    {
        select.SetActive(false);
        deposit.SetActive(true);
    }

    public void SelectWithdrawalButton()
    {
        select.SetActive(false);
        withdrawal.SetActive(true);
    }

    public void DepositBackButton()
    {
        deposit.SetActive(false);
        select.SetActive(true);
    }

    public void WithdrawalBackButton()
    {
        withdrawal.SetActive(false);
        select.SetActive(true);
    }

    public void CustomDepositButton()
    {
        //Debug.Log(depositInput.text);

        //string a = depositInput.text;
        //Debug.Log(a);

        //int abc;
        //if (int.TryParse(depositInput.text, out abc))
        //{
        //    Debug.Log(abc);
        //}
        //else
        //{
        //    Debug.Log("실패했다");
        //}

        //    depositInput.text = "바뀐거임";

        int _amount = int.Parse(depositInput.text);
        int _balance = int.Parse(balance.text);
        int _cash = int.Parse(cash.text);

        if (_cash < _amount)
        {
            notice.SetActive(true);
            return;
        }
        _cash -= _amount;
        _balance += _amount;

        depositInput.text = "";
        balance.text = _balance.ToString();
        cash.text = _cash.ToString();
    }

    public void CustomWithdrawalButton()
    {
        int _amount = int.Parse(withdrawalInput.text);
        int _balance = int.Parse(balance.text);
        int _cash = int.Parse(cash.text);

        if (_balance < _amount)
        {
            notice.SetActive(true);
            return;
        }
        _cash += _amount;
        _balance -= _amount;

        withdrawalInput.text = "";
        balance.text = _balance.ToString();
        cash.text = _cash.ToString();
    }

    public void Notice()
    {
        notice.SetActive(false);
    }
}
