---
title: "Compiler Error CS0071"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 14
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Compiler Error CS0071
An explicit interface implementation of an event must use event accessor syntax  
  
 When explicitly implementing an [event](../VS_csharp/event--csharp-reference-.md) that was declared in an interface, you must use manually provide the `add` and `remove` event accessors that are typically provided by the compiler. The accessor code can connect the interface event to another event in your class (shown later in this topic), or to its own delegate type. For more information, see [How to:  Implement Interface Events](../VS_csharp/how-to--implement-interface-events--csharp-programming-guide-.md).  
  
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