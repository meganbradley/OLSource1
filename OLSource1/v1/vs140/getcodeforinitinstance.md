---
title: "GetCodeForInitInstance"
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
  - "GetCodeForInitInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCodeForInitInstance method"
ms.assetid: cfa4cb9f-d1cc-4be6-8db9-c253655b57e4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetCodeForInitInstance
Retrieves the specified code for [InitInstance](../vs140/cwinapp--initinstance.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based line number for the start of the function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The zero-based line number for the end of the function.  
  
## Return Value  
 A string containing the code for initializing the wizard instance.  
  
## Remarks  
 Call this member function to retrieve the appropriate code for initializing the wizard instance. The line numbers are as follows:  
  
|Line number|InitInstance Code|  
|-----------------|-----------------------|  
|0|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|1|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|2|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|3|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|4|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|5|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|6|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|7|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|8|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|9|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|10|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|11|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|12|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|13|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|14|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|15|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|16|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|17|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|18|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|19|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|20|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|21|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|22|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|23|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|24|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|25|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|26|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|27|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|28|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|29|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
  
 For each of the lines returned, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> adds a leading tab (<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>) and a trailing "CR-LF" (carriage return - linefeed) character pair (<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [GetCodeForExitInstance](../vs140/getcodeforexitinstance.md)