---
title: "CMyProviderRowset (MyProviderRS.H)"
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
  - "cmyproviderrowset"
  - ""myproviderrs.h""
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE DB providers, wizard-generated files"
  - "CMyProviderRowset class in MyProviderRS.H"
ms.assetid: 7ba1a124-3842-40eb-a36b-302190a1af3a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMyProviderRowset (MyProviderRS.H)
The wizard generates an entry for the rowset object. In this case, it is called <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class inherits from an OLE DB provider class called <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which implements all the necessary interfaces for the rowset object. The following code shows the inheritance chain for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> also uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interfaces. It uses these interfaces for output fields in tables. The class also provides an implementation for **IRowsetIdentity**, which allows the consumer to determine if two rows are identical. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface implements properties for the rowset object. The **IConvertType** interface allows the provider to resolve differences between data types requested by the consumer and those used by the provider.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface actually handles data retrieval. The consumer first calls a method called <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to return a handle to a row, known as an **HROW**. The consumer then calls **IRowset::GetData** with that **HROW** to retrieve the requested data.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> also takes several template parameters. These parameters allow you to determine how the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class handles data. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument allows you to determine what storage mechanism is used to store the row data. The **RowClass** parameter specifies what class contains an **HROW**.  
  
 The **RowsetInterface** parameter allows you to also use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> interface. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interfaces both inherit from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Therefore, the OLE DB provider templates must provide special handling for these interfaces. If you want to use either of these interfaces, you need to use this parameter.  
  
## See Also  
 [Provider Wizard-Generated Files](../vs140/provider-wizard-generated-files.md)