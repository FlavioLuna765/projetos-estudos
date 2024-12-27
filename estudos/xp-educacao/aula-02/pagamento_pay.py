import requests

url = "https://sandbox.asaas.com/api/v3/customers"

payload = {
    "name": "Marcelo Almeida",
    "email": "marcelo.almeida@gmail.com",
    "phone": "4738010919",
    "mobilePhone": "4799376637",
    "cpfCnpj": "24971563792",
    "postalCode": "01310-000",
    "address": "Av. Paulista",
    "addressNumber": "150",
    "complement": "Sala 201",
    "province": "Centro",
    "externalReference": "12987382",
    "notificationDisabled": False,
    "additionalEmails": "marcelo.almeida2@gmail.com,marcelo.almeida3@gmail.com",
    "municipalInscription": "46683695908",
    "stateInscription": "646681195275",
    "observations": "ótimo pagador, nenhum problema até o momento"
}
headers = {
    "accept": "application/json",
    "content-type": "application/json"
}

response = requests.post(url, json=payload, headers=headers)

print(response.text)
