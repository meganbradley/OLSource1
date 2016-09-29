---
title: "Resource Compiler Fatal Error RC1020"
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
  - "RC1020"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RC1020"
ms.assetid: 3e073ebf-9136-4bf8-ac6a-3c642ed64594
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resource Compiler Fatal Error RC1020
unexpected '#endif'  
  
 An `#endif` directive appeared without a matching `#if`, **#ifdef**, or **#ifndef** directive.  
  
 Make sure that there is a matching `#endif` for each `#if`, **#ifdef**, and **#ifndef** statement.