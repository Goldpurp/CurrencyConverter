const Init = async () => {
  let currentRate = 0;
  var baseURL = "http://localhost:5299";

  var input1 = document.querySelector(".amount-input-1");
  var input2 = document.querySelector(".amount-input-2");
  var UpdatedRate = document.querySelector("#currentRate");

  var rateResponse = await fetch(`${baseURL}/api/Rate/get-rate`);
  var responseData = await rateResponse.json();
  currentRate = responseData.rate;

  UpdatedRate.textContent = currentRate;
  input1.value = 1;
  input2.value = currentRate;

  input1.addEventListener("input", () => {
    var gbpValue = parseFloat(input1.value);
    var ngnValue = gbpValue * currentRate;
    input2.value = ngnValue.toFixed(2);
  });

  input2.addEventListener("input", () => {
    var ngnValue = parseFloat(input2.value);
    var gbpValue = ngnValue / currentRate;
    input1.value = gbpValue.toFixed(2);
  });
};

setTimeout(Init, 2000);
