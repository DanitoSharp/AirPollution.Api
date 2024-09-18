# AirPollution.Api
This API allows users to check the air pollution levels of a specific location based on its latitude and longitude. By providing the geographic coordinates, the API returns detailed information on whether the location has significant air pollution. This can be useful for environmental monitoring, health-related applications, and more.

## Features
- Receive current atmospheric data By providing the geographic coordinates
- Forecast atmospheric data By providing the geographic coordinates

## Getting Started

### Prerequisites
- .NET 8 SDK


### Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/DanitoSharp/AirPollution.Api.git
    ```
2. Navigate to the project directory:
    ```bash
    cd DanitoSharp/AirPollution.Api
    ```
3. Restore dependencies:
    ```bash
    dotnet restore
    ```
4. Run the API:
    ```bash
    dotnet run
    ```

## API Endpoints

### Check Current AirPollution Data
**GET** `/api/airpollution/CurrentData?lat=50&lon=50`

- **Response**:
    - **200 Success**
    ```json
{ 
        "coord":
        {
            50,
            50
        },
        "list":
        [
            {
                "dt":1605182400,
                "main":{
                    "aqi":1
                },
                "components":{
                "co":201.94053649902344,
                "no":0.01877197064459324,
                "no2":0.7711350917816162,
                "o3":68.66455078125,
                "so2":0.6407499313354492,
                "pm2_5":0.5,
                "pm10":0.540438711643219,
                "nh3":0.12369127571582794
                }
            }
        ]
}

### Forecast AirPollution Data
**GET** `/api/airpollution/ForcastData?lat=50&lon=50`

- **Response**:
    - **200 Success**
    ```json
{ 
        "coord":
        {
            50,
            50
        },
        "list":
        [
            {
                "dt":1605182400,
                "main":{
                    "aqi":1
                },
                "components":{
                "co":201.94053649902344,
                "no":0.01877197064459324,
                "no2":0.7711350917816162,
                "o3":68.66455078125,
                "so2":0.6407499313354492,
                "pm2_5":0.5,
                "pm10":0.540438711643219,
                "nh3":0.12369127571582794
                }
            }
        ]
    }

## Error Codes

| Status Code               | Description                         |
|---------------------------|-------------------------------------|
| 200 OK                    | Request succeeded.                  |
| 400 Bad Request           | Validation error or invalid data.   |
| 404 Not Found             | The resource was not found.         |
| 500 Internal Server Error | Unexpected server error.            |


## Support
If you have any issues or questions, please contact [Ekelemedaniel12@gmail.com].
