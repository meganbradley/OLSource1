---
title: "Creating Registrar Scripts"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scripting, registry scripting"
  - "ATL, registry"
  - "registrar scripts [ATL]"
  - "scripts, Registrar scripts"
  - "scripts, creating"
ms.assetid: cbd5024b-8061-4a71-be65-7fee90374a35
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating Registrar Scripts
A registrar script provides data-driven, rather than API-driven, access to the system registry. Data-driven access is typically more efficient since it takes only one or two lines in a script to add a key to the registry.  
  
 The [ATL Control Wizard](../VS_csharp/atl-control-wizard.md) automatically generates a registrar script for your COM server. You can find this script in the .rgs file associated with your object.  
  
 The ATL Registrar's Script Engine processes your registrar script at run time. ATL automatically invokes the Script Engine during server setup.  
  
 This article covers the following topics related to the registrar scripts:  
  
-   [Understanding Backus Nauer Form (BNF) Syntax](../VS_csharp/understanding-backus-nauer-form--bnf--syntax.md)  
  
-   [Understanding Parse Trees](../VS_csharp/understanding-parse-trees.md)  
  
-   [Registry Scripting Examples](../VS_csharp/registry-scripting-examples.md)  
  
-   [Using Replaceable Parameters (The Registrar's Preprocessor)](../VS_csharp/using-replaceable-parameters--the-registrar-s-preprocessor-.md)  
  
-   [Invoking Scripts](../VS_csharp/invoking-scripts.md)  
  
## See Also  
 [Registry Component (Registrar)](../VS_csharp/atl-registry-component--registrar-.md)