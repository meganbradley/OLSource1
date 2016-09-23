---
title: "CImage::Save"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CImage.Save
  - ATL.CImage.Save
  - ATL::CImage::Save
  - CImage::Save
dev_langs: 
  - C++
helpviewer_keywords: 
  - GUID_BMPFile method
  - Save method
  - GUID_PNGFile method
  - GUID_JPEGFile method
  - GUID_GIFFile method
ms.assetid: 48442b7f-e897-49bd-95a1-a4c4b465582c
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImage::Save
Saves an image to the specified stream or file on disk.  
  
## Syntax  
  
```  
  
      HRESULT Save(  
   IStream* pStream,  
   REFGUID guidFileType  
) const throw();  
HRESULT Save(  
   LPCTSTR pszFileName,  
   REFGUID guidFileType= GUID_NULL  
) const throw();  
```  
  
#### Parameters  
 `pStream`  
 A pointer to a COM IStream object containing the file image data.  
  
 *pszFileName*  
 A pointer to the file name for the image.  
  
 `guidFileType`  
 The file type to save the image as. Can be one of the following:  
  
-   **ImageFormatBMP** An uncompressed bitmap image.  
  
-   **ImageFormatPNG** A Portable Network Graphic (PNG) compressed image.  
  
-   **ImageFormatJPEG** A JPEG compressed image.  
  
-   **ImageFormatGIF** A GIF compressed image.  
  
> [!NOTE]
>  For a complete list of constants, see [Image File Format Constants](_gdiplus_constant_image_file_format_constants) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A standard `HRESULT`.  
  
## Remarks  
 Call this function to save the image using a specified name and type. If the `guidFileType` parameter is not included, the file name's file extension will be used to determine the image format. If no extension is provided, the image will be saved in BMP format.  
  
## Example:  
 [!code[NVC_ATLMFC_Utilities#72](../vs140/codesnippet/CPP/cimage--save_1.cpp)]
  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::Load](../vs140/cimage--load.md)