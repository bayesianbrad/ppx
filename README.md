# PPX [![Build Status](https://travis-ci.org/probprog/ppx.svg?branch=master)](https://travis-ci.org/probprog/ppx)

<p align="left"><img width="40%" src="docs/ppx_logo.png" /></p>

`PPX` is a cross-platform [**P**robabilistic **P**rogramming](http://www.probabilistic-programming.org) e**X**ecution protocol and API based on [flatbuffers](https://google.github.io/flatbuffers/). It is intended as an open interoperability protocol between models and inference engines implemented in different probabilistic programming languages.

Probabilistic programming is about the execution probabilistic models under the control of inference engines, and `PPX` allows the model and the inference engine to be
* implemented in different programming languages and
* executed in separate processes and on separate machines across networks.

`PPX` is inspired by [ONNX](https://onnx.ai/), the Open Neural Network Exchange project allowing interoperability between major deep learning frameworks.

## Installing Flatbuffers

In the terminal type the following:

```
git clone https://github.com/google/flatbuffers.git
cd flatbuffers
cmake -G "Unix Makefiles"
make
```

## Using PPX

Define the `ppx.fb` script and run 
```shell
sh compile.sh
```

## Supported languages

We provide `PPX` compiled to all programming languages officially supported by flatbuffers. These are:

* C++
* C#
* Dart
* Go
* Java
* JavaScript
* Lobster
* Lua
* PHP
* Python
* Rust
* TypeScript

## License

`PPX` is distributed under the BSD License.

## Authors

`PPX` has been developed by

* [Atılım Güneş Baydin](http://www.robots.ox.ac.uk/~gunes/)
* [Tuan Anh Le](http://www.tuananhle.co.uk/)
* [Lukas Heinrich](http://www.lukasheinrich.com/)
* [Wahid Bhimji](http://www.nersc.gov/about/nersc-staff/data-analytics-services/wahid-bhimji/)
* [Kyle Cranmer](http://theoryandpractice.org/)
* [Frank Wood](http://www.cs.ubc.ca/~fwood/index.html)
