---
title: "Creating a Simple Read-Only Provider"
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
  - "OLE DB providers, creating"
  - "OLE DB provider templates, creating providers"
ms.assetid: ade8ccdd-9ea4-4e46-a964-18460c2a2401
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating a Simple Read-Only Provider
When you have created an OLE DB provider using the ATL Project Wizard and ATL OLE DB Provider Wizard, you can add other functionality that you want to support. Start designing your provider by examining what kind of data you will be sending to the consumer and under what conditions. It is especially important to determine whether you need to support commands, transactions, and other optional objects. A good design up front will speed implementation and testing.  
  
 The example is presented in two parts:  
  
-   The first part shows how to [create a simple read-only provider](../vs140/implementing-the-simple-read-only-provider.md) that reads a pair of strings.  
  
-   The second part shows how to [enhance the simple read-only provider](../vs140/enhancing-the-simple-read-only-provider.md) by adding the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> interface.  
  
## See Also  
 [Creating an OLE DB Provider](../vs140/creating-an-ole-db-provider.md)