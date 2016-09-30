---
title: "IMPLEMENT_DYNCREATE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IMPLEMENT_DYNCREATE"
  - "AFX/IMPLEMENT_DYNCREATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run-time object model services macros"
  - "IMPLEMENT_DYNCREATE macro"
ms.assetid: 89ebcfa1-cc4d-49eb-a09b-8618f44f5e98
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IMPLEMENT_DYNCREATE
Enables objects of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived classes to be created dynamically at run time when used with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *class_name*  
 The actual name of the class.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The actual name of the base class.  
  
## Remarks  
 The framework uses this ability to create new objects dynamically, for example, when it reads an object from disk during serialization. Add the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro in the class implementation file. For more information, see [CObject Class Topics](../vs140/using-cobject.md).  
  
 If you use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> macros, you can then use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> macro and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function to determine the class of your objects at run time.  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is included in the class declaration, then <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must be included in the class implementation.  
  
 Note that this macro definition will invoke the default constructor for your class. If a non-trivial constructor is explicitly implemented by the class, it must also explicitly implement the default constructor as well. The default constructor can be added to the class's **private** or **protected** member sections to prevent it from being called from outside the class implementation.  
  
## Example  
 [!code[NVC_MFCCObjectSample#22](../vs140/codesnippet/CPP/implement_dyncreate_1.h)]  
  
 [!code[NVC_MFCCObjectSample#23](../vs140/codesnippet/CPP/implement_dyncreate_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_DYNCREATE](../vs140/declare_dyncreate.md)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)   
 [CObject::IsKindOf](../vs140/cobject--iskindof.md)