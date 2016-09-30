---
title: "CMyProviderCommand (MyProviderRS.H)"
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
  - "cmyprovidercommand"
  - ""myproviderrs.h""
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE DB providers, wizard-generated files"
  - "CMyProviderCommand class in MyProviderRS.H"
ms.assetid: b30b956e-cc91-4cf5-9fe6-f8b1ce9cc2a5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMyProviderCommand (MyProviderRS.H)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class is the implementation for the provider command object. It provides the implementation for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and **ICommandProperties** interfaces. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface is the same as the one in the rowset. The command object uses the accessor to specify bindings for parameters. The rowset object uses them to specify bindings for output columns. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface is a useful way to specify a command textually. This example uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface later when it adds custom code; it also overrides the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method. The **ICommandProperties** interface handles all of the properties for the command and rowset objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface manages all the bindings used in commands and rowsets. The consumer calls **IAccessor::CreateAccessor** with an array of **DBBINDING** structures. Each **DBBINDING** structure contains the information about how the column bindings should be handled (such as type and length). The provider receives the structures and then determines how the data should be transferred and whether any conversions are necessary. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface is used in the command object to handle any parameters in the command.  
  
 The command object also provides an implementation of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. OLE DB requires the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface. The interface allows the consumer to retrieve information about parameters from the command. The rowset object uses the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> interface to return information about the output columns to the provider.  
  
 The provider also contains an interface called <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface was implemented in ATL 2.0 and allows the implementer to pass information about itself to its child. The command object uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> information to tell any generated rowset objects about who created them.  
  
## See Also  
 [Provider Wizard-Generated Files](../vs140/provider-wizard-generated-files.md)