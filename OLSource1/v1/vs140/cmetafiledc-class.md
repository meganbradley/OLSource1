---
title: "CMetaFileDC Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CMetaFileDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMetaFileDC class"
  - "Windows metafiles [C++]"
  - "metafiles, implementing"
ms.assetid: ffce60fa-4181-4d46-9832-25e46fad4db4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMetaFileDC Class
Implements a Windows metafile, which contains a sequence of graphics device interface (GDI) commands that you can replay to create a desired image or text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMetaFileDC::CMetaFileDC](#cmetafiledc__cmetafiledc)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMetaFileDC::Close](#cmetafiledc__close)|Closes the device context and creates a metafile handle.|  
|[CMetaFileDC::CloseEnhanced](#cmetafiledc__closeenhanced)|Closes an enhanced-metafile device context and creates an enhanced-metafile handle.|  
|[CMetaFileDC::Create](#cmetafiledc__create)|Creates the Windows metafile device context and attaches it to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[CMetaFileDC::CreateEnhanced](#cmetafiledc__createenhanced)|Creates a metafile device context for an enhanced-format metafile.|  
  
## Remarks  
 To implement a Windows metafile, first create a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. Invoke the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> constructor, then call the [Create](#cmetafiledc__create) member function, which creates a Windows metafile device context and attaches it to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
 Next send the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object the sequence of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> GDI commands that you intend for it to replay. Only those GDI commands that create output, such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, can be used.  
  
 After you have sent the desired commands to the metafile, call the **Close** member function, which closes the metafile device contexts and returns a metafile handle. Then dispose of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
 [CDC::PlayMetaFile](../vs140/cdc-class.md#cdc__playmetafile) can then use the metafile handle to play the metafile repeatedly. The metafile can also be manipulated by Windows functions such as                 [CopyMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183480), which copies a metafile to disk.  
  
 When the metafile is no longer needed, delete it from memory with the                 [DeleteMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183537) Windows function.  
  
 You can also implement the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object so that it can handle both output calls and attribute GDI calls such as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Such a metafile is more flexible and can more easily reuse general GDI code, which often consists of a mix of output and attribute calls. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class inherits two device contexts, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> device context handles all [CDC](../vs140/cdc-class.md) GDI output calls and the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> device context handles all <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> GDI attribute calls. Normally, these two device contexts refer to the same device. In the case of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the attribute DC is set to **NULL** by default.  
  
 Create a second device context that points to the screen, a printer, or device other than a metafile, then call the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> member function to associate the new device context with <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. GDI calls for information will now be directed to the new <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. Output GDI calls will go to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, which represents the metafile.  
  
 For more information on <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, see [Device Contexts](../vs140/device-contexts.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CDC](../vs140/cdc-class.md)  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="cmetafiledc__close">\</a>  CMetaFileDC::Close  
 Closes the metafile device context and creates a Windows metafile handle that can be used to play the metafile by using the [CDC::PlayMetaFile](../vs140/cdc-class.md#cdc__playmetafile) member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A valid **HMETAFILE** if the function is successful; otherwise **NULL**.  
  
### Remarks  
 The Windows metafile handle can also be used to manipulate the metafile with Windows functions such as                         [CopyMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183480).  
  
 Delete the metafile after use by calling the Windows                         [DeleteMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183537) function.  
  
##  \<a name="cmetafiledc__closeenhanced">\</a>  CMetaFileDC::CloseEnhanced  
 Closes an enhanced-metafile device context and returns a handle that identifies an enhanced-format metafile.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A handle of an enhanced metafile, if successful; otherwise **NULL**.  
  
### Remarks  
 An application can use the enhanced-metafile handle returned by this function to perform the following tasks:  
  
-   Display a picture stored in an enhanced metafile  
  
-   Create copies of the enhanced metafile  
  
-   Enumerate, edit, or copy individual records in the enhanced metafile  
  
-   Retrieve an optional description of the metafile contents from the enhanced-metafile header  
  
-   Retrieve a copy of the enhanced-metafile header  
  
-   Retrieve a binary copy of the enhanced metafile  
  
-   Enumerate the colors in the optional palette  
  
-   Convert an enhanced-format metafile into a Windows-format metafile  
  
 When the application no longer needs the enhanced metafile handle, it should release the handle by calling the Win32 **DeleteEnhMetaFile** function.  
  
##  \<a name="cmetafiledc__cmetafiledc">\</a>  CMetaFileDC::CMetaFileDC  
 Construct a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object in two steps.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 First, call <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, then call **Create**, which creates the Windows metafile device context and attaches it to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmetafiledc__create">\</a>  CMetaFileDC::Create  
 Construct a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object in two steps.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *lpszFilename*  
 Points to a null-terminated character string. Specifies the filename of the metafile to create. If                                 *lpszFilename* is **NULL**, a new in-memory metafile is created.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 First, call the constructor <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, then call **Create**, which creates the Windows metafile device context and attaches it to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmetafiledc__createenhanced">\</a>  CMetaFileDC::CreateEnhanced  
 Creates a device context for an enhanced-format metafile.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Identifies a reference device for the enhanced metafile.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Points to a null-terminated character string. Specifies the filename for the enhanced metafile to be created. If this parameter is **NULL**, the enhanced metafile is memory based and its contents lost when the object is destroyed or when the Win32 **DeleteEnhMetaFile** function is called.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) data structure or a [CRect](../vs140/crect-class.md) object that specifies the dimensions in **HIMETRIC** units (in .01-millimeter increments) of the picture to be stored in the enhanced metafile.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Points to a zero-terminated string that specifies the name of the application that created the picture, as well as the picture's title.  
  
### Return Value  
 A handle of the device context for the enhanced metafile, if successful; otherwise **NULL**.  
  
### Remarks  
 This DC can be used to store a device-independent picture.  
  
 Windows uses the reference device identified by the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> parameter to record the resolution and units of the device on which a picture originally appeared. If the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter is **NULL**, it uses the current display device for reference.  
  
 The left and top members of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> data structure pointed to by the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> parameter must be smaller than the right and bottom members, respectively. Points along the edges of the rectangle are included in the picture. If <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is **NULL**, the graphics device interface (GDI) computes the dimensions of the smallest rectangle that can enclose the picture drawn by the application. The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> parameter should be supplied where possible.  
  
 The string pointed to by the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter must contain a null character between the application name and the picture name and must terminate with two null characters —for example, "XYZ Graphics Editor\0Bald Eagle\0\0," where \0 represents the null character. If <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is **NULL**, there is no corresponding entry in the enhanced-metafile header.  
  
 Applications use the DC created by this function to store a graphics picture in an enhanced metafile. The handle identifying this DC can be passed to any GDI function.  
  
 After an application stores a picture in an enhanced metafile, it can display the picture on any output device by calling the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> function. When displaying the picture, Windows uses the rectangle pointed to by the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> parameter and the resolution data from the reference device to position and scale the picture. The device context returned by this function contains the same default attributes associated with any new DC.  
  
 Applications must use the Win32 **GetWinMetaFileBits** function to convert an enhanced metafile to the older Windows metafile format.  
  
 The filename for the enhanced metafile should use the .EMF extension.  
  
## See Also  
 [Base Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)