---
title: "Querying the .Pdb File"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PDB files"
  - ".pdb files, querying"
ms.assetid: 8da07d1c-2712-45f9-8fbf-f34040408a8a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Querying the .Pdb File
A program database file (extension .pdb) is a binary file that contains type and symbolic debugging information gathered over the course of compiling and linking the project. A PDB file is created when you compile a C/C++ program with **/ZI** or **/Zi** or a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)], or [!INCLUDE[jsprjscript](../vs140/includes/jsprjscript_md.md)] program with the **/debug** option. Object files contain references into the .pdb file for debugging information. For more information on pdb files, see [PDB Files](assetId:///1761c84e-8c2c-4632-9649-b5f99964ed3f). A DIA application can use the following general steps to obtain details about the various symbols, objects, and data elements within an executable image.  
  
### To query the .pdb file  
  
1.  Acquire a data source by creating an [IDiaDataSource](../vs140/idiadatasource.md) interface.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Call [IDiaDataSource::loadDataFromPdb Method](../vs140/idiadatasource--loaddatafrompdb.md) or [IDiaDataSource::loadDataForExe Method](../vs140/idiadatasource--loaddataforexe.md) to load the debugging information.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Call [IDiaDataSource::openSession](../vs140/idiadatasource--opensession.md) to open an [IDiaSession](../vs140/idiasession.md) to gain access to the debugging information.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Use the methods in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to query for the symbols in the data source.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  Use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interfaces to enumerate and scan through the symbols or other elements of debug information.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [IDiaDataSource](../vs140/idiadatasource.md)