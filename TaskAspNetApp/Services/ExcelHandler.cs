using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TaskAspNetApp.Models;

namespace TaskAspNetApp.Services
{
	public class ExcelHandler
	{
		IWorkbook workbook;
		public ExcelHandler(Stream stream, string fileEx)
		{
			if (fileEx == ".xlsx")
				workbook = new XSSFWorkbook(stream);
			else if (fileEx == ".xls")
				workbook = new HSSFWorkbook(stream);
			else return;
		}
		~ExcelHandler()
		{
			workbook.Close();
		}
		public List<Contract> GetContractsFromExcel()
		{
			try
			{
				List<Contract> contracts = new List<Contract>();
				for (int s = 0; s < workbook.NumberOfSheets; s++)
				{
					ISheet sheet = workbook.GetSheetAt(s);

					if (sheet != null)
					{

						if (sheet.SheetName == "ДОГОВОРЫ")
						{
							List<string> headersString = new List<string>();
							foreach (var HeadCell in sheet.GetRow(0))
							{
								headersString.Add(GetCellValue(HeadCell).ToString());
							}
							for (int i = 1; i <= sheet.LastRowNum; i++)
							{
								Contract contract = new Contract();
								foreach (var cell in sheet.GetRow(i))
								{
									if (cell.ColumnIndex < headersString.Count)
									{
										string curHead = headersString.ElementAt(cell.ColumnIndex);
										switch (curHead)
										{
											case "ИДЕНТИФИКАТОР":
												contract.Id = Convert.ToInt32(GetCellValue(cell));
												break;
											case "ШИФР ДОГОВОРА":
												contract.Code = GetCellValue(cell).ToString();
												break;
											case "НАИМЕНОВАНИЕ ДОГОВОРА":
												contract.Name = GetCellValue(cell).ToString();
												break;
											case "ЗАКАЗЧИК":
												contract.Client = GetCellValue(cell).ToString();
												break;
										}

									}
								}
								contracts.Add(contract);
							}
						}
						else if (sheet.SheetName == "ЭТАПЫ ДОГОВОРА")
						{
							List<string> headersString = new List<string>();
							foreach (var HeadCell in sheet.GetRow(0))
							{
								headersString.Add(GetCellValue(HeadCell).ToString());
							}
							for (int i = 1; i <= sheet.LastRowNum; i++)
							{
								StageContract stageContract = new StageContract();
								int contractId = -1;
								foreach (var cell in sheet.GetRow(i))
								{
									if (cell.ColumnIndex < headersString.Count)
									{
										string curHead = headersString.ElementAt(cell.ColumnIndex);
										switch (curHead)
										{
											case "ИДЕНТИФИКАТОР ДОГОВОРА":
												contractId = Convert.ToInt32(GetCellValue(cell));
												break;
											case "НАИМЕНОВАНИЕ ЭТАПА":
												stageContract.Name = GetCellValue(cell).ToString();
												break;
											case "ДАТА НАЧАЛА":
												stageContract.DateStart = FromExcelSerialDate(Convert.ToInt32(GetCellValue(cell)));
												break;
											case "ДАТА ОКОНЧАНИЯ":
												stageContract.DateEnd = FromExcelSerialDate(Convert.ToInt32(GetCellValue(cell)));
												break;
										}
									}
								}
								try
								{
									contracts.Where(c => c.Id == contractId).First().Stages.Add(stageContract);
								}
								catch (Exception e)
								{
									Console.WriteLine("IMPORT ERROR: " + e.Message);
								}

							}
						}
					}
				}
				contracts.ForEach(c => c.Id = 0);
				return contracts;
			}
			catch (Exception e)
			{
				Console.WriteLine("IMPORT ERROR: " + e.Message);
				return null;
			}

		}
		private object GetCellValue(ICell cell)
		{
			object cellvalue;
			switch (cell.CellType)
			{
				case CellType.Numeric:
					cellvalue = cell.NumericCellValue;
					break;
				case CellType.String:
					cellvalue = cell.StringCellValue;
					break;
				case CellType.Blank:
					cellvalue = null;
					break;
				case CellType.Boolean:
					cellvalue = cell.BooleanCellValue;
					break;
				case CellType.Error:
					cellvalue = cell.ErrorCellValue;
					break;
				case CellType.Formula:
					cellvalue = cell.CellFormula;
					break;
				case CellType.Unknown:
					cellvalue = null;
					break;
				default:
					cellvalue = null;
					break;
			}
			return cellvalue;
		}

		private DateTime FromExcelSerialDate(int SerialDate)
		{
			if (SerialDate > 59) SerialDate -= 1;
			return new DateTime(1899, 12, 31).AddDays(SerialDate);
		}
	}
}



