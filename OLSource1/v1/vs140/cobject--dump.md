---
title: "CObject::Dump"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CObject::Dump"
  - "Dump"
  - "CObject.Dump"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObject class, diagnostics"
  - "Dump method"
ms.assetid: 209696a4-1623-489e-9324-c4f2e9a445e0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObject::Dump
Dumps the contents of your object to a [CDumpContext](../vs140/cdumpcontext-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The diagnostic dump context for dumping, usually <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 When you write your own class, you should override the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function to provide diagnostic services for yourself and other users of your class. The overridden <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> usually calls the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function of its base class before printing data members unique to the derived class. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> prints the class name if your class uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> macro.  
  
> [!NOTE]
>  Your <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function should not print a newline character at the end of its output.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> calls make sense only in the Debug version of the Microsoft Foundation Class Library. You should bracket calls, function declarations, and function implementations with **#ifdef _DEBUG**/<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statements for conditional compilation.  
  
 Since <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a **const** function, you are not permitted to change the object state during the dump.  
  
 The [CDumpContext insertion (<<) operator](../vs140/cdumpcontext--operator---.md) calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> when a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> pointer is inserted.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> permits only "acyclic" dumping of objects. You can dump a list of objects, for example, but if one of the objects is the list itself, you will eventually overflow the stack.  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class used in all <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#9](../vs140/codesnippet/CPP/cobject--dump_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CObject Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)