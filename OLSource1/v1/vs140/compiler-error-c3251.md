---
title: "Compiler Error C3251"
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
  - C3251
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3251
ms.assetid: 541c163e-5ee9-457c-a1e5-da860788b10d
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3251
cannot invoke base class method on a value type instance  
  
 The following error occurs because `GetClass` is a member of `Microsoft.Runtime.Object`, not of `Microsoft.Runtime.Integer4`.