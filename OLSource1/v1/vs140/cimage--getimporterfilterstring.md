---
title: "CImage::GetImporterFilterString"
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
  - "CImage::GetImporterFilterString"
  - "CImage.GetImporterFilterString"
  - "GetImporterFilterString"
  - "ATL::CImage::GetImporterFilterString"
  - "ATL.CImage.GetImporterFilterString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImporterFilterString method"
ms.assetid: 3be45a9a-1377-4ecf-9129-3d7c02eba48e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::GetImporterFilterString
Finds image formats available for loading images.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *strImporters*  
 A reference to a **CSimpleString** object. See **Remarks** for more information.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An array of GUIDs, with each element corresponding to one of the file types in the string. In the example in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> below, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[0] is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with the remaining array values are the image file formats supported by the current operating system.  
  
> [!NOTE]
>  For a complete list of constants, see [Image File Format Constants](_gdiplus_constant_image_file_format_constants) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If this parameter is not **NULL**, the filter string will have one additional filter at the beginning of the list. This filter will have the current value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for its description, and accepts files of any extension supported by any other exporter in the list.  
  
 For example:  
  
 [!code[NVC_ATLMFC_Utilities#74](../vs140/codesnippet/CPP/cimage--getimporterfilterstring_1.cpp)]  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Set of bit flags specifying which file types to exclude from the list. Allowable flags are:  
  
-   **excludeGIF** = 0x01   Excludes GIF files.  
  
-   **excludeBMP** = 0x02   Excludes BMP (Windows Bitmap) files.  
  
-   **excludeEMF** = 0x04   Excludes EMF (Enhanced Metafile) files.  
  
-   **excludeWMF** = 0x08   Excludes WMF (Windows Metafile) files.  
  
-   **excludeJPEG** = 0x10   Excludes JPEG files.  
  
-   **excludePNG** = 0x20   Excludes PNG files.  
  
-   **excludeTIFF** = 0x40   Excludes TIFF files.  
  
-   **excludeIcon** = 0x80   Excludes ICO (Windows Icon) files.  
  
-   **excludeOther** = 0x80000000   Excludes any other file type not listed above.  
  
-   **excludeDefaultLoad** = 0   For load, all file types are included by default  
  
-   **excludeDefaultSave** = **excludeIcon &#124; excludeEMF &#124; excludeWMF** For saving, these files are excluded by default because they usually have special requirements.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The separator used between the image formats. See **Remarks** for more information.  
  
## Remarks  
 You can pass the resulting format string to your MFC [CFileDialog](../vs140/cfiledialog-class.md) object to expose the file extensions of the available image formats in the **File Open** dialog box.  
  
 The parameter *strImporter* has the format:  
  
 file description0&#124;\*.ext0&#124;filedescription1&#124;\*.ext1&#124;...file description*n*&#124;\*.ext*n*&#124;&#124;  
  
 where '&#124;' is the separator character specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For example:  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 Use the default separator '&#124;' if you pass this string to an MFC <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object. Use the null separator '\0' if you pass this string to a common **File Open** dialog box.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::GetExporterFilterString](../vs140/cimage--getexporterfilterstring.md)   
 [CFileDialog::m_ofn](../vs140/cfiledialog--m_ofn.md)   
 [CFileDialog::GetFileExt](../vs140/cfiledialog--getfileext.md)   
 [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839)   
 [CFileDialog::SetDefExt](../vs140/cfiledialog--setdefext.md)