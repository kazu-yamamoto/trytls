from setuptools import setup, find_packages

setup(
    name="trytls",
    version="0.0.3",
    packages=find_packages(),
    entry_points={
        "console_scripts": ["trytls=showrunner.runner:main"]
    }
)
