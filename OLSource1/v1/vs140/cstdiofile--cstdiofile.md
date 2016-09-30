---
title: "CStdioFile::CStdioFile"
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
  - "CStdioFile::CStdioFile"
  - "CStdioFile.CStdioFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStdioFile method"
  - "CStdioFile class, construction/destruction"
ms.assetid: db832846-c0b6-4026-92bc-3e745c95da04
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStdioFile::CStdioFile
Constructs and initializes a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the file pointer returned by a call to the C run-time function [fopen](../vs140/fopen--_wfopen.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies a string that is the path to the desired file. The path can be relative or absolute.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies options for file creation, file sharing, and file access modes. You can specify multiple options by using the bitwise OR (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) operator.  
  
 One file access mode option is required; other modes are optional. See [CFile::CFile](../vs140/cfile--cfile.md) for a list of mode options and other flags. In MFC version 3.0 and later, share flags are allowed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object.  
  
## Remarks  
 The default constructor does not attach a file to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. When using this constructor, you must use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method to open a file and attach it to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
 The single-parameter constructor attaches an open file stream to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. Allowed pointer values include the predefined input/output file pointers <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The two-parameter constructor creates a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object and opens the corresponding file with the given path.  
  
 If you pass <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for either <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the constructor throws a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 If the file cannot be opened or created, the constructor throws a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCFiles#37](../vs140/codesnippet/CPP/cstdiofile--cstdiofile_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CStdioFile Class](../vs140/cstdiofile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)