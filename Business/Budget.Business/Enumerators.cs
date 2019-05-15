namespace Budget.Business {

	public enum CommandResult {

		Ok,
		Error

	}

	public enum FrequencyType : byte {

		OneTime = 1,
		MonthlyCumulative,
		MonthlySet,
		Quarterly,
		Yearly

	}

}