---
title: "Provider Support for Bookmarks"
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
  - "IRowsetLocate class, provider support for bookmarks"
  - "OLE DB provider templates, bookmarks"
  - "bookmarks, OLE DB"
  - "IRowsetLocate class"
  - "OLE DB providers, bookmark support"
ms.assetid: 1b14ccff-4f76-462e-96ab-1aada815c377
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Provider Support for Bookmarks
The example in this topic adds the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class. In almost all cases, you start by adding an interface to an existing COM object. You can then test it by adding more calls from the consumer templates. The example demonstrates how to:  
  
-   Add an interface to a provider.  
  
-   Dynamically determine the columns to return to the consumer.  
  
-   Add bookmark support.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface inherits from the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> interface. To add the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface, inherit <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> from [IRowsetLocateImpl](../vs140/irowsetlocateimpl-class.md).  
  
 Adding the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interface is a bit different from most interfaces. To make the VTABLEs line up, the OLE DB provider templates have a template parameter to handle the derived interface. The following code shows the new inheritance list:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The fourth, fifth, and sixth parameters are all added. This example uses the defaults for the fourth and fifth parameters but specify <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> as the sixth parameter. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is an OLE DB template class that takes two template parameters: these hook up the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> interface to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class. To add most interfaces, you can skip this step and move to the next one. Only the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> interfaces need to be handled in this way.  
  
 You then need to tell the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to call <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> interface. Add the line <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to the map. The interface map for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> should appear as shown in the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You also need to hook your map into the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class. Add in the COM_INTERFACE_ENTRY_CHAIN macro to hook in the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> map. Also, create a typedef called <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> that consists of the inheritance information. This typedef is arbitrary and can be ignored.  
  
 Finally, handle the **IColumnsInfo::GetColumnsInfo** call. You would normally use the PROVIDER_COLUMN_ENTRY macros to do this. However, a consumer might want to use bookmarks. You must be able to change the columns the provider returns depending on whether the consumer asks for a bookmark.  
  
 To handle the **IColumnsInfo::GetColumnsInfo** call, delete the **PROVIDER_COLUMN** map in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class. The PROVIDER_COLUMN_MAP macro defines a function <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. You need to define your own <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> function. The function declaration should look like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Then, implement the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function in the MyProviderRS.cpp file as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> first checks to see whether a property called **DBPROP_IRowsetLocate** is set. OLE DB has properties for each of the optional interfaces off the rowset object. If the consumer wants to use one of these optional interfaces, it sets a property to true. The provider can then check this property and take special action based on it.  
  
 In your implementation, you get the property by using the pointer to the command object. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> pointer represents the rowset or command class. Because you use templates here, you have to pass this in as a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> pointer or the code does not compile.  
  
 Specify a static array to contain the column information. If the consumer does not want the bookmark column, an entry in the array is wasted. You can dynamically allocate this array, but you would need to make sure to destroy it properly. This example defines and uses the macros ADD_COLUMN_ENTRY and ADD_COLUMN_ENTRY_EX to insert the information into the array. You can add the macros to the MyProviderRS.H file as shown in the following code:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 To test the code in the consumer, you need to make a few changes to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> handler. The first change to the function is that you add code to add a property to the property set. The code sets the **DBPROP_IRowsetLocate** property to true, thus telling the provider that you want the bookmark column. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> handler code should appear as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The while loop contains code to call the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> interface. The code you have should always pass because you are comparing the exact same bookmarks. Also, store one bookmark in a temporary variable so that you can use it after the while loop finishes to call the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function in the consumer templates. The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function calls the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 You also need to update the user record in the consumer. Add an entry in the class to handle a bookmark and an entry in the **COLUMN_MAP**:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 When you have updated the code, you should be able to build and execute the provider with the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> interface.  
  
## See Also  
 [Advanced Provider Techniques](../vs140/advanced-provider-techniques.md)