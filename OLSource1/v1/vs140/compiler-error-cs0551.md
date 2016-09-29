---
title: "Compiler Error CS0551"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0551"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0551"
ms.assetid: fb456ecf-dff3-4e39-b9b3-de23d81dadea
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0551
Explicit interface implementation 'implementation' is missing accessor 'accessor'  
  
 A class that explicitly implements an interface's property must implement all the accessors that the interface defines.  
  
 For more information, see [Using Properties (C# Programming Guide)](../vs140/using-properties--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0551.  
  
```  
// CS0551.cs  
// compile with: /target:library  
interface ii  
{  
   int i  
   {  
      get;  
      set;  
   }  
}  
  
public class a : ii  
{  
   int ii.i { set {} }   // CS0551  
  
   // OK  
   int ii.i      
   {  
      set {}  
      get { return 0; }  
   }  
}  
```