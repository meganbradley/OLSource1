---
title: "CArchive::operator &lt;&lt;"
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
  - "CArchive.operator<<"
  - "CArchive::operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "64-bit integers [C++]"
  - "CArchive class, basic input/output"
  - "<< operator"
  - "64-bit integers [C++], storing"
  - "I/O [C++], CArchive class"
  - "operator <<, archive"
  - "operator<<, archive"
ms.assetid: 0870b7b5-7d3a-424f-a59f-824a39a119e0
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::operator &lt;&lt;
Stores the indicated object or primitive type to the archive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> reference that enables multiple insertion operators on a single line.  
  
## Remarks  
 The last two versions above are specifically for storing 64-bit integers.  
  
 If you used the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro in your class implementation, then the insertion operator overloaded for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> calls the protected **WriteObject**. This function, in turn, calls the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function of the class.  
  
 The [CStringT](../vs140/cstringt-class.md) insertion operator (<<) supports diagnostic dumping and storing to an archive.  
  
## Example  
 This example demonstrates the use of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> insertion operator << with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> types.  
  
 [!code[NVC_MFCSerialization#31](../vs140/codesnippet/CPP/carchive--operator---_1.cpp)]  
  
## Example  
 This example 2 demonstrates the use of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> insertion operator << with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type.  
  
 [!code[NVC_MFCSerialization#32](../vs140/codesnippet/CPP/carchive--operator---_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::WriteObject](../vs140/carchive--writeobject.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)   
 [CStringT Class](../vs140/cstringt-class.md)   
 [CDumpContext Class](../vs140/cdumpcontext-class.md)