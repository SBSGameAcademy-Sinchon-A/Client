using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject[] UIPanels;

    Stack<int> userInterfaceStack = new Stack<int>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EscapeUI()
    {
        if (userInterfaceStack.Count == 0)
        {
            // �Ͻ�����
        }
        else
        {
            if (userInterfaceStack.Count == 1)
            {
                Time.timeScale = 1f;
            }

            UIPanels[userInterfaceStack.Pop()].SetActive(false);
        }


    }
}
