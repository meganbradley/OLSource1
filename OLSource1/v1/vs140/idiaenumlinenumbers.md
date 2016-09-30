---
title: "IDiaEnumLineNumbers"
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
  - "IDiaEnumLineNumbers interface"
ms.assetid: cdf07b4f-19e4-4dcd-8af8-c2dbca586a7c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumLineNumbers
Enumerates the various line numbers contained in the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumLineNumbers::get__NewEnum](../vs140/idiaenumlinenumbers--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumLineNumbers::get_Count](../vs140/idiaenumlinenumbers--get_count.md)|Retrieves the number of line numbers.|  
|[IDiaEnumLineNumbers::Item](../vs140/idiaenumlinenumbers--item.md)|Retrieves a line number by means of an index.|  
|[IDiaEnumLineNumbers::Next](../vs140/idiaenumlinenumbers--next.md)|Retrieves a specified number of line numbers in the enumeration sequence.|  
|[IDiaEnumLineNumbers::Skip](../vs140/idiaenumlinenumbers--skip.md)|Skips a specified number of line numbers in an enumeration sequence.|  
|[IDiaEnumLineNumbers::Reset](../vs140/idiaenumlinenumbers--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumLineNumbers::Clone](../vs140/idiaenumlinenumbers--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
  
## Notes for Callers  
 This interface is obtained by calling one of the following methods in the [IDiaSession](../vs140/idiasession.md) interface:  
  
-   [IDiaSession::findLines](../vs140/idiasession--findlines.md)  
  
-   [IDiaSession::findLinesByAddr](../vs140/idiasession--findlinesbyaddr.md)  
  
-   [IDiaSession::findLinesByRVA](../vs140/idiasession--findlinesbyrva.md)  
  
-   [IDiaSession::findLinesByVA](../vs140/idiasession--findlinesbyva.md)  
  
-   [IDiaSession::findLinesByLinenum](../vs140/idiasession--findlinesbylinenum.md)  
  
## Example  
 This example shows how to obtain the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface from a session. In this case, the example shows how to get the line number enumeration for a function (represented by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>). For a more complete example of using line numbers, see the [IDiaLineNumber](../vs140/idialinenumber.md) interface.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSession::findLinesByLinenum](../vs140/idiasession--findlinesbylinenum.md)   
 [IDiaSession::findLinesByRVA](../vs140/idiasession--findlinesbyrva.md)   
 [IDiaSession::findLinesByVA](../vs140/idiasession--findlinesbyva.md)   
 [IDiaSession::findLines](../vs140/idiasession--findlines.md)   
 [IDiaSession::findLinesByAddr](../vs140/idiasession--findlinesbyaddr.md)