---
title: "Linker Tools Warning LNK4104"
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
  - "LNK4104"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4104"
ms.assetid: ca6728db-d616-419a-a570-65e8445c6079
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4104
export of symbol 'symbol' should be PRIVATE  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> can be one of the following:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 This warning is emitted when you are building an import library for a DLL and export one of the above functions without specifying it as PRIVATE in the module-definition file. In general, these functions are exported for use only by OLE. Placing them in the import library can lead to unusual behavior when a program linked to the library incorrectly makes calls to them. For more information about the PRIVATE keyword, see [EXPORTS](../vs140/exports.md).