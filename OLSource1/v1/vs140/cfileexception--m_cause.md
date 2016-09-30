---
title: "CFileException::m_cause"
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
  - "CFileException.m_cause"
  - "CFileException::m_cause"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enum CFileException"
  - "m_cause"
  - "CFileException class, data members"
  - "CFileException class, enumerated types"
ms.assetid: 5cb21301-2671-4007-9659-adae06ecb5ef
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileException::m_cause
Contains values defined by a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> enumerated type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This data member is a public variable of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The enumerators and their meanings are as follows:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> 0: No error occurred.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> 1: An unspecified error occurred.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> 2: The file could not be located.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> 3: All or part of the path is invalid.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> 4: The permitted number of open files was exceeded.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> 5: The file could not be accessed.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> 6: There was an attempt to use an invalid file handle.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> 7: The current working directory cannot be removed.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> 8: There are no more directory entries.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> 9: There was an error trying to set the file pointer.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> 10: There was a hardware error.  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> 11: SHARE.EXE was not loaded, or a shared region was locked.  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> 12: There was an attempt to lock a region that was already locked.  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> 14: The disk is full.  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> 15: The end of file was reached.  
  
    > [!NOTE]
    >  These <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> cause enumerators are distinct from the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> cause enumerators.  
  
    > [!NOTE]
    >  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is deprecated. Use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> instead. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is used in an application and built with /clr, the resulting syntax errors are not easy to decipher.  
  
## Example  
 [!code[NVC_MFCFiles#30](../vs140/codesnippet/CPP/cfileexception--m_cause_1.cpp)]  
  
## Requirements  
 Header: afx.h  
  
## See Also  
 [CFileException Class](../vs140/cfileexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)