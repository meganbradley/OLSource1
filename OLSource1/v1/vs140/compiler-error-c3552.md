---
title: "Compiler Error C3552"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3552
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3552
ms.assetid: 83401524-1bf1-44c0-8aca-a6eb35c4224c
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3552
'typename': a late specified return type cannot contain 'auto'  
  
 If you use the `auto` keyword as a placeholder for the return type of a function, you must provide a late-specified return type. However, you cannot use another `auto` keyword to specify the late-specified return type. For example, the following code fragment yields error C3552.  
  
 `auto myFunction->auto; // C3552`