/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

/**
 * Provides a way of storing data for mindpowered packages.
 * When mindpowered packages need to persist data, they will use Get and Mutate, which in turn will call the Mutators and Getters you have set up.
 * You can set up the Mutators and Getters however you like whether to access a database such as MySQL or MongoDB, or simply write and read from text files.
 */
public class Persistence
{

	/**
	 * Set up a Mutator to change stored data
	 * @param recordType type of record being changed (eg. databsae table name)
	 * @param operationName action being performed on the record (eg. insert, update)
	 * @param strategyMethod method to call to actually perform the mutation
	 * @param updateMapper method to call on recordData before calling strategyMethod with the results
	*/
	AddMutator(recordType, operationName, strategyMethod, updateMapper)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [recordType, operationName, strategyMethod, updateMapper];
		//TODO: bus.call('Persistence.AddMutator', args);
	}

	/**
	 * Set up a Getter to retrieve data
	 * @param recordType type of record being retrieved (eg. databsae table name)
	 * @param operationName query being performed for the record type (eg. findById, findByName, findActive, getInsertedId)
	 * @param strategyMethod method to call to actually perform the data retrieval
	 * @param queryMapper method to call on queryValues before calling strategyMethod with the results
	 * @param resultMapper method to call on data returned from the strategyMethod before returning the results
	*/
	AddGetter(recordType, operationName, strategyMethod, queryMapper, resultMapper)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [recordType, operationName, strategyMethod, queryMapper, resultMapper];
		//TODO: bus.call('Persistence.AddGetter', args);
	}

	/**
	 * Use a Mutator to change stored data
	 * @param recordType type of record being changed (eg. databsae table name)
	 * @param operationName action being performed on the record (eg. insert, update)
	 * @param recordData data being updated or saved by passing through updateMapper and then strategyMethod
	*/
	Mutate(recordType, operationName, recordData)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [recordType, operationName, recordData];
		//TODO: bus.call('Persistence.Mutate', args);
	}

	/**
	 * Use a Getter to retrieve data
	 * @param recordType type of record being retrieved (eg. databsae table name)
	 * @param operationName query being performed for the record type (eg. findById, findByName, findActive, getInsertedId)
	 * @param queryValues values that will be passed through queryMapper and then strategyMethod to perform the query
	 * @return {number} The x value.
	*/
	Get(recordType, operationName, queryValues)
	{
		//TODO: C# let bus = maglev.maglev.MagLev.getInstance('default');
		//TODO: C# let args = [recordType, operationName, queryValues];
		//TODO: C# let ret = bus.call('Persistence.Get', args);
		//TODO: C# return ret;
	}

}

