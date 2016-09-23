---
title: "Debugger navigation sample code (Xaml and C#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.assetid: 8f4266bc-4597-43ab-b620-8b08ea988a8e
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Debugger navigation sample code (Xaml and C#)
The code in this topic is the sample file for the [Walkthrough: Debugger Basics](../vs140/navigate-a-debugging-session-in-visual-studio--xaml-and-csharp-.md) topic.  
  
## Sample Code  
  
```c#  
public MainPage()  
{  
    InitializeComponent();  
    methodTrack = "Main Page";             
    Example1();  
}  
  
int Example1()  
{  
    int a = 1;  
    methodTrack += "->Example1 ";  
    int x = Example1_A();  
    return a;  
}  
  
int Example1_A()  
{  
    int b = 2;  
    methodTrack += "->Example1_B ";  
    return b;  
}  
  
void Example2()  
{  
    int c = 3;  
    methodTrack += "->Example2 ";  
    int x = Example2_A();  
    int y = Example2_A();  
    int z = Example2_B();  
}  
  
int Example2_A()  
{  
    int c = 3;  
    methodTrack += "->Example2_A ";  
    return c;  
}  
  
int Example2_B()  
{  
    int d = 3;  
    methodTrack += "->Example2_B ";  
    return d;  
}  
  
void Example3()  
{  
    string s = String.Empty;  
    for (int i = 0; i < 1000; i++)  
    {  
        s += i.ToString() + '\n';  
    }  
    methodTrack += "->Example3 ";  
  
}  
  
void Example4()  
{  
    int x = 0;  
    int y = 100;  
    if (x != 0)  
    {  
        x = 1;  
    }  
    double result = y / x;  
    methodTrack = "->Example4";  
}  
  
string methodTrack = String.Empty;  
  
```