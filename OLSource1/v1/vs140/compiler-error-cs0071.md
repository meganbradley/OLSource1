---
title: "Compiler Error CS0071"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0071"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0071"
ms.assetid: 787cbeae-fb2b-455a-ba10-811b956ed170
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0071
An explicit interface implementation of an event must use event accessor syntax  
  
 When explicitly implementing an [event](../vs140/event--csharp-reference-.md) that was declared in an interface, you must use manually provide the `add` and `remove` event accessors that are typically provided by the compiler. The accessor code can connect the interface event to another event in your class (shown later in this topic), or to its own delegate type. For more information, see [How to: Implement Interface Events (C# Programming Guide)](../vs140/how-to--implement-interface-events--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0071.  
  
```  
// CS0071.cs  
public delegate void MyEvent(object sender);  
  
interface ITest  
{  
    event MyEvent Clicked;  
}  
  
class Test : Itest  
{  
    event MyEvent ITest.Clicked;  // CS0071  
  
    // try the following code instead  
/*  
private MyEvent clicked;  
  
    event MyEvent Itest.Clicked  
    {  
        add  
        {  
            clicked += value;  
        }  
        remove  
        {  
            clicked -= value;  
        }  
    }  
*/  
    public static void Main() { }  
}  
```