---
title: "Serialization: Serialization vs. Database Input-Output"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Serialization: Serialization vs. Database Input/Output"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "database applications [C++], file I/O vs. serialization"
  - "serialization [C++], vs. database I/O"
  - "I/O [C++], vs. serialization"
  - "databases [C++], input/output handling"
ms.assetid: f1d23d77-4761-4a52-a7ea-54fc92d347ea
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Serialization: Serialization vs. Database Input-Output
This article explains when to use document objects and serialization for file-based input/output (I/O) and when other I/O techniques are appropriate — because the application reads and writes data on a per-transaction basis, as in database applications. If you don't use serialization, you also won't need the File Open, Save, and Save As commands. Topics covered include:  
  
-   [Recommendations for handling input/output](../VS_csharp/recommendations-for-handling-input-output.md)  
  
-   [Handling the File menu in database applications](../VS_csharp/file-menu-in-an-mfc-database-application.md)  
  
## See Also  
 [Serialization](../VS_csharp/serialization-in-mfc.md)