---
title: "Consuming Generics (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Consuming Generics (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "generics [C++], consuming from .NET languages"
ms.assetid: e6330ef5-e907-432e-b527-7a22f5899639
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Consuming Generics (C++-CLI)
Generics authored in one .NET language may be used in other .NET languages. Unlike templates, a generic in a compiled assembly still remains generic. Thus, one may instantiate the generic type in a different assembly and even in a different language than the assembly in which the generic type was defined.  
  
## Remarks  
 For more information, see:  
  
-   [Generics (C#)](../vs140/introduction-to-generics--csharp-programming-guide-.md)  
  
-   [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)  
  
## Example  
  
### Description  
 This example shows a generic class defined in C#.  
  
### Code  
  
```  
// consuming_generics_from_other_NET_languages.cs  
// compile with: /target:library  
// a C# program  
public class CircularList<ItemType> {  
   class ListNode    {  
      public ItemType m_item;  
      public ListNode next;  
      public ListNode(ItemType item) {  
         m_item = item;  
      }  
   }  
  
   ListNode first, last;  
  
   public CircularList() {}  
  
   public void Add(ItemType item) {  
      ListNode newnode = new ListNode(item);  
      if (first == null) {  
         first = last = newnode;  
         first.next = newnode;  
         last.next = first;  
      }  
      else {  
         newnode.next = first;  
         first = newnode;  
         last.next = first;  
      }   
   }  
  
   public void Remove(ItemType item) {  
      ListNode iter = first;  
      if (first.m_item.Equals( item )) {  
         first =   
         last.next = first.next;  
      }  
      for ( ; iter != last ; iter = iter.next )  
         if (iter.next.m_item.Equals( item )) {  
              if (iter.next == last)  
                  last = iter;  
              iter.next = iter.next.next;  
              return;  
          }  
   }  
  
   public void PrintAll() {  
      ListNode iter = first;  
      do {  
         System.Console.WriteLine( iter.m_item );  
         iter = iter.next;  
      } while (iter != last);  
   }  
}  
```  
  
## Example  
  
### Description  
 This example consumes the assembly authored in C#.  
  
### Code  
  
```  
// consuming_generics_from_other_NET_languages_2.cpp  
// compile with: /clr  
#using <consuming_generics_from_other_NET_languages.dll>  
using namespace System;  
class NativeClass {};  
ref class MgdClass {};  
  
int main() {  
   CircularList<int>^ circ1 = gcnew CircularList<int>();  
   CircularList<MgdClass^>^ circ2 = gcnew CircularList<MgdClass^>();  
  
   for (int i = 0 ; i < 100 ; i += 10)  
      circ1->Add(i);  
   circ1->Remove(50);  
   circ1->PrintAll();  
}  
```  
  
### Output  
  
```  
90  
80  
70  
60  
40  
30  
20  
10  
```  
  
## See Also  
 [Generics (C++)](../vs140/generics---c---component-extensions-.md)