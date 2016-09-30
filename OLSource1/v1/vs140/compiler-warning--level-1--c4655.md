---
title: "Compiler Warning (level 1) C4655"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4655"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4655"
ms.assetid: 540f2c7a-e4a1-49af-84b4-03eeea1bbf41
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4655
**'**   
 ***symbol* ' : variable type is new since the last build, or is defined differently elsewhere**  
  
 You changed or added a new data type since the last successful build. Edit and Continue does not support changes to existing data types.  
  
 This warning is followed by a [Fatal Error C1092](../vs140/fatal-error-c1092.md). For further information, see the [Supported Code Changes](../vs140/supported-code-changes--c---.md).  
  
### To remove this warning without ending the current debug session  
  
1.  Change the data type back to its state prior to the error.  
  
2.  From the **Debug** menu, choose **Apply Code Changes**.  
  
### To remove this warning without changing your source code  
  
1.  From the **Debug** menu, choose **Stop Debugging**.  
  
2.  From the **Build** menu, choose **Build**.