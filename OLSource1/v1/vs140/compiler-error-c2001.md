---
title: "Compiler Error C2001"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2001"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2001"
ms.assetid: 0c3a7821-d8e5-4398-ab5a-4116d46e8dda
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2001
newline in constant  
  
 A string constant cannot be continued on a second line unless you do the following:  
  
-   End the first line with a backslash.  
  
-   Close the string on the first line with a double quotation mark and open the string on the next line with another double quotation mark.  
  
 Ending the first line with \n is not sufficient.  
  
## Example  
 The following sample generates C2001:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Spaces at the beginning of the next line after a line-continuation character are included in the string constant. None of the examples shown above embed a newline character into the string constant. You can embed a newline character as shown here:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>