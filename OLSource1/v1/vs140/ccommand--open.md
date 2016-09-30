---
title: "CCommand::Open"
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
  - "ATL.CCommand.Open"
  - "ATL::CCommand::Open"
  - "CCommand.Open"
  - "CCommand::Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open method"
ms.assetid: 4c9b8f31-faf3-452d-9a29-3d3e5f54d6f8
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommand::Open
Executes and optionally binds the command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The session in which to execute the command.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The command to execute, passed as a Unicode string. Can be **NULL** when using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, in which case the command will be retrieved from the value passed to the [DEFINE_COMMAND](../vs140/define_command.md) macro. See [ICommand::Execute](https://msdn.microsoft.com/en-us/library/ms718095.aspx) in the *OLE DB Programmer's Reference* for details.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Same as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> except that this parameter takes an ANSI command string. The fourth form of this method can take a NULL value. See "Remarks" later in this topic for details.  
  
 *pPropSet*  
 [in] A pointer to an array of [DBPROPSET](https://msdn.microsoft.com/en-us/library/ms714367.aspx) structures containing properties and values to be set. See [Property Sets and Property Groups](https://msdn.microsoft.com/en-us/library/ms713696.aspx) in the *OLE DB Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in/out] A pointer to memory where the count of rows affected by a command is returned. If *\*pRowsAffected* is **NULL**, no row count is returned. Otherwise, **Open** sets *<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> according to the following conditions:  
  
|If|Then|  
|--------|----------|  
|The **cParamSets** element of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is greater than 1|*<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> represents the total number of rows affected by all of the parameter sets specified in the execution.|  
|The number of affected rows is not available|*<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set to –1.|  
|The command does not update, delete, or insert rows|*<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is undefined.|  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [in] A GUID that specifies the syntax and general rules for the provider to use in parsing the command text. See [ICommandText::GetCommandText](https://msdn.microsoft.com/en-us/library/ms709825.aspx) and [ICommandText::SetCommandText](https://msdn.microsoft.com/en-us/library/ms709757.aspx) in the *OLE DB Programmer's Reference* for details.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [in] Specifies whether to bind the command automatically after being executed. The default is **true**, which causes the command to be bound automatically. Setting <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to **false** prevents the automatic binding of the command so that you can bind manually. (Manual binding is of particular interest to OLAP users.)  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [in] The number of [DBPROPSET](https://msdn.microsoft.com/en-us/library/ms714367.aspx) structures passed in the *pPropSet* argument.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first three forms of **Open** take a session, create a command, and execute the command, binding any parameters as necessary.  
  
 The first form of **Open** takes a Unicode command string and has no default value.  
  
 The second form of **Open** takes an ANSI command string and no default value (provided for backward compatibility with existing ANSI applications).  
  
 The third form of **Open** allows the command string to be NULL, because of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> with a default value of NULL. It is provided for calling <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> because NULL is of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. This version requires and asserts that the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter be NULL.  
  
 Use the fourth form of **Open** when you have already created a command and you want to perform a single [Prepare](../vs140/ccommand--prepare.md) and multiple executions.  
  
> [!NOTE]
>  **Open** calls **Execute**, which in turn calls <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CCommand Class](../vs140/ccommand-class.md)