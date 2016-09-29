---
title: "Compiler Warning (level 1) C4951"
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
  - "C4951"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4951"
ms.assetid: 669d8bb7-5efa-4ba9-99db-4e65addbf054
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4951
'function' has been edited since profile data was collected, function profile data not used  
  
 A function has been edited in an input module to [/LTCG:PGUPDATE](../vs140/-ltcg--link-time-code-generation-.md), so that the profile data is now not valid. The input module was recompiled after **/LTCG:PGINSTRUMENT** and has a function (***function***) with a different flow of control than was in the module at the time of the **/LTCG:PGINSTRUMENT** operation.  
  
 This warning is informational. To resolve this warning, run **/LTCG:PGINSTRUMENT**, redo all test runs, and run **/LTCG:PGOPTIMIZE**.  
  
 This warning would be replaced with an error if **/LTCG:PGOPTIMIZE** had been used.