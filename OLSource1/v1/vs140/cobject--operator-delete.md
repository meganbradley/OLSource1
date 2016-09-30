---
title: "CObject::operator delete"
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
  - "CObject::operatordelete"
  - "operatordelete"
  - "CObject.operatordelete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator delete [MFC]"
  - "CObject class, construction/destruction"
ms.assetid: b1b73e64-b2d4-4b22-82b4-5bc68d83507d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObject::operator delete
For the Release version of the library, operator **delete** frees the memory allocated by operator **new**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the Debug version, operator **delete** participates in an allocation-monitoring scheme designed to detect memory leaks.  
  
 If you use the code line  
  
 [!code[NVC_MFCCObjectSample#14](../vs140/codesnippet/CPP/cobject--operator-delete_1.cpp)]  
  
 before any of your implementations in a .CPP file, then the third version of **delete** will be used, storing the filename and line number in the allocated block for later reporting. You do not have to worry about supplying the extra parameters; a macro takes care of that for you.  
  
 Even if you do not use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in Debug mode, you still get leak detection, but without the source-file line-number reporting described above.  
  
 If you override operators **new** and **delete**, you forfeit this diagnostic capability.  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class used in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#15](../vs140/codesnippet/CPP/cobject--operator-delete_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CObject Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject::operator new](../vs140/cobject--operator-new.md)