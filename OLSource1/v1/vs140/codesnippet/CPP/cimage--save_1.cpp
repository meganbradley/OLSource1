   // Demonstrating saving various file formats
   // save an image in BMP format
   m_myImage.Save(_T("c:\\temp\\image1.bmp"));
   // save an image in BMP format
   m_myImage.Save(_T("c:\\temp\\image2"), Gdiplus::ImageFormatBMP);
   // save an image in JPEG format
   m_myImage.Save(_T("c:\\temp\\image3.jpg"));
   // save an image in BMP format, even though jpg file extension is used
   m_myImage.Save(_T("c:\\temp\\image4.jpg"), Gdiplus::ImageFormatBMP);