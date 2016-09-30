---
title: "Consumer Wizard-Generated Methods"
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
  - "OpenAll method"
  - "attribute-injected classes and methods"
  - "wizard-generated classes and methods"
  - "OLE DB consumers, wizard-generated classes and methods"
  - "methods [C++], OLE DB Consumer Wizard-generated"
  - "CloseDataSource method"
  - "consumer wizard-generated classes and methods"
  - "OpenDataSource method"
  - "CloseAll method"
  - "OpenRowset method"
  - "GetRowsetProperties method"
ms.assetid: d80ee51c-8bb3-4dca-8760-5808e0fb47b4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Consumer Wizard-Generated Methods
The ATL OLE DB Consumer Wizard and the MFC Application Wizard generate certain functions of which you should be aware. Note that some methods are implemented differently in attributed projects, so there are a few caveats; each case is covered below. For information about viewing injected code, see [Debugging Injected Code](../vs140/how-to--debug-injected-code.md).  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> opens the data source, rowsets, and turns on bookmarks if they are available.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> closes all open rowsets and releases all command executions.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is called by OpenAll to open the consumer's rowset or rowsets.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> retrieves a pointer to the rowset's property set with which properties can be set.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> opens the data source using the initialization string you specified in the **Data Link Properties** dialog box.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> closes the data source in an appropriate manner.  
  
## OpenAll and CloseAll  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following example shows how you can call <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> when you execute the same command repeatedly. Compare the code example in [CCommand::Close](../vs140/ccommand--close.md), which shows a variation that calls **Close** and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Remarks  
 Note that if you define a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> code sets the DBPROP_IRowsetLocate property; make sure you only do this if your provider supports that property.  
  
## OpenRowset  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **OpenAll** calls this method to open the rowset or rowsets in the consumer. Typically, you do not need to call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> unless you want to work with multiple data sources/sessions/rowsets. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is declared in the command or table class header file:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The attributes implement this method differently. This version takes a session object and a command string that defaults to the command string specified in db_command, although you can pass a different one. Note that if you define a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> code sets the DBPROP_IRowsetLocate property; make sure you only do this if your provider supports that property.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## GetRowsetProperties  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 This method retrieves a pointer to the rowset's property set; you can use this pointer to set properties such as DBPROP_IRowsetChange. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is used in the user record class as follows. You can modify this code to set additional rowset properties:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Remarks  
 You should not define a global <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method because it could conflict with the one defined by the wizard. Note that this is a wizard-generated method that you get with templated and attributed projects; the attributes do not inject this code.  
  
## OpenDataSource and CloseDataSource  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Remarks  
 The wizard defines the methods <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> calls [CDataSource::OpenFromInitializationString](../vs140/cdatasource--openfrominitializationstring.md).  
  
## See Also  
 [Creating an OLE DB Consumer Using a Wizard](../vs140/creating-an-ole-db-consumer-using-a-wizard.md)