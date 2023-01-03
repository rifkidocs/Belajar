/* eslint-disable react/jsx-key */

import React from "react";
import Navbar from "./components/Navbar";
import Hero from "./components/Hero";
import Card from "./components/Card";
import Data from "./components/Data";

export default function App() {
	const dataElements = Data.map((data) => {
		return (
			<Card
				img={data.coverImg}
				rating={data.stats.rating}
				reviewCount={data.stats.reviewCount}
				country={data.location}
				title={data.title}
				price={data.price}
			/>
		);
	});

	return (
		<div>
			<Navbar />
			<Hero />
			<section className="cards-list">{dataElements}</section>
		</div>
	);
}
