---
title: "CMyProviderWindowsFile"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "cmyproviderwindowsfile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMyProviderWindowsFile class"
  - "OLE DB providers, wizard-generated files"
ms.assetid: 0e9e72ac-1e1e-445f-a7ac-690c20031f9d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMyProviderWindowsFile
The wizard creates a class to contain one row of data; in this case, it is called <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The following code for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is wizard generated and lists all the files in a directory by using the **WIN32_FIND_DATA** structure. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> inherits from the **WIN32_FIND_DATA** structure:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is called the [user record class](../vs140/user-record.md) because it also contains a map describing the columns in the provider's rowset. The provider column map contains one entry for each field in the rowset using the PROVIDER_COLUMN_ENTRY macros. The macros specify column name, ordinal, and offset to a structure entry. The provider column entries in the above code contain offsets into the **WIN32_FIND_DATA** structure. When the consumer calls **IRowset::GetData**, data is transferred in one contiguous buffer. Rather than making you do pointer arithmetic, the map allows you to specify a data member.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class also contains the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is what actually reads the data in from the native source. The following code shows the wizard-generated <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method. The function uses the Win32 **FindFirstFile** and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> APIs to retrieve information about the files in the directory and place them in instances of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The directory to search is represented by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>; this contains the text represented by the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interface in the command object. If no directory is specified, it uses the current directory.  
  
 The method creates one entry for each file (corresponding to a row) and places it in the **m_rgRowData** data member. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class defines the **m_rgRowData** data member. The data in this array represents the entire table and is used throughout the templates.  
  
## See Also  
 [Provider Wizard-Generated Files](../vs140/provider-wizard-generated-files.md)