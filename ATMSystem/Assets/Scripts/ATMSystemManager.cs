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
        Debug.Log(depositInput.text);

        string a = depositInput.text;
        Debug.Log(a);

        int aaa = Convert.ToInt32(a);
        Debug.Log(aaa);

        int _amount = int.Parse(depositInput.text);
        int _balance = int.Parse(balance.text);
        int _cash = int.Parse(cash.text);

        if (_balance < _amount)
        {
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
        int _amount = int.Parse(withdrawalInput.text.ToString());
        int _balance = int.Parse(balance.text);


    }
}
