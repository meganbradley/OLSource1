---
title: "Reading Strings into the OLE DB Provider"
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
  - "OLE DB providers, reading strings into"
ms.assetid: 517f322c-f37e-4eed-bf5e-dd9a412c2f98
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reading Strings into the OLE DB Provider
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function opens a file and reads strings. The consumer passes the file name to the provider by calling [ICommandText::SetCommandText](https://msdn.microsoft.com/en-us/library/ms709757.aspx). The provider receives the file name and stores it in the member variable <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> reads the file name from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If the file name is invalid or the file is unavailable, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns an error. Otherwise, it opens the file and calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to retrieve the strings. For each set of strings it reads, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> creates an instance of the user record (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) and places it into an array.  
  
 If the file cannot be opened, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must return **DB_E_NOTABLE**. If it returns **E_FAIL** instead, the provider will not work with many consumers and will not pass the OLE DB [conformance tests](../vs140/testing-your-provider.md).  
  
## Example  
  
### Description  
 The edited <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function looks like this:  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Implementing the Simple Read-Only Provider](../vs140/implementing-the-simple-read-only-provider.md)