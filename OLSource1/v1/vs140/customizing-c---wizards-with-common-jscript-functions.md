---
title: "Customizing C++ Wizards with Common JScript Functions"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - wizard JScript methods, creating C++ wizards
ms.assetid: c602978f-a2c4-462f-85c3-50b5897bec46
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Customizing C++ Wizards with Common JScript Functions
When you create a wizard project with the [Custom Wizard](../vs140/creating-a-custom-wizard.md), your project includes Common.js. If you specify a user interface for your wizard, the project also contains HTML pages that specify the JScript script language and include the file Common.js, as follows:  
  
```  
<SCRIPT ID="INCLUDE_COMMON" LANGUAGE ="JSCRIPT"></SCRIPT>  
```  
  
 The wizard also creates a unique file called Default.js. You can customize your own JScript functions in Default.js. See [The JScript File](../vs140/jscript-file.md) for more information.  
  
 Common.js contains functions that you can call from each wizard's HTML pages and from Default.js. If you have the same functions that you would like to use across different wizards, you can place these functions in Common.js.  
  
## See Also  
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)