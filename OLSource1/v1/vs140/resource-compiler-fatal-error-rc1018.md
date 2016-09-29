---
title: "Resource Compiler Fatal Error RC1018"
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
  - "RC1018"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RC1018"
ms.assetid: bb1d2efd-6898-412f-bb03-9ff94c54e4dc
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resource Compiler Fatal Error RC1018
unexpected '#elif'  
  
 The `#elif` directive did not appear within an `#if`, **#ifdef**, or **#ifndef** construct.  
  
 Make sure that there is an `#if`, **#ifdef**, or **#ifndef** statement in effect before this statement.