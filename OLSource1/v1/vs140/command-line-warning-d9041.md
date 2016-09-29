---
title: "Command-Line Warning D9041"
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
  - "D9041"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "D9041"
ms.assetid: ada8815f-4246-4e25-b57d-a7f16fa107cc
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Command-Line Warning D9041
invalid value 'value' for '/option'; assuming 'value'; add '/analyze' to command-line options when specifying this warning  
  
 A Code Analysis warning number was added to the **/wd**, **/we**, **/wo**, or **/wl** command line option without also specifying the **/analyze** command line option. To remedy this error, either add the **/analyze** command line option, or remove the invalid warning number from the appropriate **/w** command line option.  
  
## Example  
 The following command line example generates the warning D9041:  
  
```  
cl /EHsc /LD /wd6001 filename.cpp  
```  
  
 To fix the warning, add the **/analyze** command line option. If **/analyze** is not supported on your version of the compiler, remove the invalid warning number from the **/wd** option.  
  
## See Also  
 [Command-Line Errors D8000 Through D9999](../vs140/command-line-errors-d8000-through-d9999.md)   
 [Compiler Options](../vs140/compiler-options.md)