﻿using ExcelDataReader;
using StudentDataAnalysatorMultiPlat.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentDataAnalysatorMultiPlat.Enums.Enums;

namespace StudentDataAnalysatorMultiPlat.Services.ExcelServices
{
    public class ExcelDataReaderService
    {
        private string path;
        StudentsResultsExcelReaderService studentsExcelReaderService = new StudentsResultsExcelReaderService();
        StudentsLogsExcelReaderSerivice logsExcelReaderService = new StudentsLogsExcelReaderSerivice();

        public ExcelDataReaderService()
        {

        }

        public ExcelDataReaderService(string path)
        {
            this.path = path;
        }

        public bool IsFileExcel(string path)
        {
            string fileExt = Path.GetExtension(path);

            if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                return true;
            else
                return false;
        }

        public int GetTableType()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                var reader = ExcelReaderFactory.CreateReader(stream);
                return reader.FieldCount > 2 ? (int)TableTypeEnum.StudentsLogsTable : (int)TableTypeEnum.StudentsResultTable;
            }
        }

        public ObservableCollection<Student> GetStudentListFromExcelTable()
        {
            studentsExcelReaderService.ReadExcel(path);

            return studentsExcelReaderService.StudentsList;
        }

        public ObservableCollection<Log> GetLogListFromExcelTable()
        {
            logsExcelReaderService.ReadExcel(path);

            return logsExcelReaderService.LogsList;
        }

        public bool IsTableStudentsResults()
        {
            return GetTableType() == (int)TableTypeEnum.StudentsResultTable;
        }

    }
}
