---
title: "CLS Compliance Warning CLS03302"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CLS03302"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLS03302"
ms.assetid: 3b99e64b-d5cb-4eb8-81b5-fd96992f2c10
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLS Compliance Warning CLS03302
Events shall adhere to a specific naming pattern  
  
 Events shall adhere to a specific naming pattern; the name of the event's accessor functions will be the same as the event name, prepended with **raise_**, **remove_**, or **add_**.  
  
 The **specialname** attribute shall be ignored in appropriate name comparisons and shall adhere to identifier rules.  
  
 For more information CLS compliance checking, see [CLS Compliant Assemblies](assetId:///3320b57e-ea55-4697-a17d-f509a36a3c93).  
  
 The following function declaration (using MSIL assembly language) shows what could cause CLS03302:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Notice that the names of the accessor methods differ from the name of the event.  By ensuring that all event accessor names adhere to the naming pattern, you can resolve CLS03302.